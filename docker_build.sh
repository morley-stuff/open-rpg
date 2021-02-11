UNITY_VERSION=2019.3.7f1
docker run -it --rm \
-e "UNITY_USERNAME=${UNITY_USERNAME}" \
-e "UNITY_PASSWORD=${UNITY_PASSWORD}" \
-e "UNITY_LOC=/opt/unity/Editor/Unity" \
-e "LICENSE_FILE=/root/project/Unity_v2020.x.ulf" \
-e "WORKDIR=/root/project" \
-v "$(pwd):/root/project" \
unityci/editor:ubuntu-2020.1.1f1-android-0.3.0 \
bash -c /root/project/build.sh